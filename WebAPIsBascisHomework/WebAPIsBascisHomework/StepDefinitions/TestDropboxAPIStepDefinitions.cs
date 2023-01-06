using System;
using System.Net;
using System.Text.Json;
using TechTalk.SpecFlow;
using WebAPIsBascisHomework.Drivers;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;
using NUnit.Framework;
using WebAPIsBascisHomework.Api;
using System.Collections.Specialized;
using WebAPIsBascisHomework.Api.EndpointResult;

namespace WebAPIsBascisHomework.StepDefinitions
{
    [Binding]
    public class TestDropboxAPIStepDefinitions
    {
        private ApiEndpoint _endpoint;
        private ApiEndPointResult _response;
        private string _lastUploadMetadata;
        private string _testFilePath = Directory.GetCurrentDirectory() + @"\Resource\Test.txt";

        [Given(@"I set body for upload file to (.*)")]
        public void GivenISetBodyForUploadFileFromA_TxtToMy_Txt(string dropboxFileName)
        {
            byte[] file = File.ReadAllBytes(_testFilePath);
            _endpoint = new UploadApiEndpoint(file, dropboxFileName);
        }

        [Given(@"I set body for delete file by (.*)")]
        public void GivenISetBodyForDeleteFileByMy_Txt(string dropboxFileName)
        {
            Dictionary<string, string> content = new()
            {
                {"path", "/" + dropboxFileName}
            };
            _endpoint = new DeleteApiEndpoint(content);
        }

        [Given(@"I set body for get metadata file from (.*)")]
        public void GivenISetBodyForGetMetadataFileFromMy_Txt(string dropboxFileName)
        {
            Dictionary<string, string> content = new()
            {
                {"path", "/" + dropboxFileName}
            };
            _endpoint = new GetMetadataApiEndpoint(content);
        }

        [Given(@"I don`t have file in disk with (.*)")]
        public void GivenIDontHaveFileInDiskWithMy_Txt(string dropboxFileName)
        {
            List<string> files = GetAllFilesInDiskNames();
            if (files.Contains(dropboxFileName))
            {
                GivenISetBodyForDeleteFileByMy_Txt(dropboxFileName);
                WhenISendPOSTRequest();
            }
        }

        [Given(@"I have file in disk with (.*)")]
        public void GivenIHaveFileInDiskWithMy_Txt(string dropboxFileName)
        {
            List<string> files = GetAllFilesInDiskNames();
            if (!files.Contains(dropboxFileName))
            {
                GivenISetBodyForUploadFileFromA_TxtToMy_Txt(dropboxFileName);
                WhenISendPOSTRequest();
            }
        }

        [Given(@"I upload file to disk with (.*)")]
        public void GivenIUploadFileInDiskWithMy_Txt(string dropboxFileName)
        {
            GivenIDontHaveFileInDiskWithMy_Txt(dropboxFileName);
            GivenISetBodyForUploadFileFromA_TxtToMy_Txt(dropboxFileName);
            WhenISendPOSTRequest();
        }

        [Given(@"I save it metadata")]
        public void GivenISaveItMetadata()
        {
            _lastUploadMetadata = _response.Body;
        }

        [When(@"I send POST request")]
        public void WhenISendPOSTRequest()
        {
            _response = _endpoint.Post();
        }

        [Then(@"I receive valid HTTP response code (.*)")]
        public void ThenIReceiveValidHTTPResponseCode(int statusCode)
        {
            Assert.That((int)_response.StatusCode == statusCode);
        }

        [Then(@"Metadata is same as for uploaded file")]
        public void ThenMetadataIsSameAsForUploadedFile()
        {
            string lastCallMetadataJson = _response.Body;
            Dictionary<string, object>  uploadMetadata = JsonSerializer.Deserialize<Dictionary<string, object>>(_lastUploadMetadata);
            Dictionary<string, object>  lastCallMetadata = JsonSerializer.Deserialize<Dictionary<string, object>>(lastCallMetadataJson);
            if (lastCallMetadata[".tag"].ToString() == "file")
                lastCallMetadata.Remove(".tag");
            else
                Assert.Fail();
            foreach (var uploadKeyValue in uploadMetadata)
            {
                var lastCallValue = lastCallMetadata[uploadKeyValue.Key];
                if (lastCallValue.ToString() != uploadKeyValue.Value.ToString())
                {
                    Assert.Fail();
                }
            }
            Assert.Pass();
        }

        [Then(@"I don`t have file in disk with (.*)")]
        public void ThenIDonTHaveFileInDiskWithMy_Txt(string filename)
        {
            List<string> files = GetAllFilesInDiskNames();
            Assert.That(!files.Contains(filename));
        }

        public List<string> GetAllFilesInDiskNames()
        {
            Dictionary<string, string> content = new()
            {
                {"path", ""}
            };
            ApiEndpoint endpoint = new ListFolderApiEndpoint(content);
            ListFolderApiEndpointResult response = (endpoint.Post() as ListFolderApiEndpointResult);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception("Status code not 200 it is " + response.StatusCode.ToString());
            }
            return response.FileNames();
        }
    }
}
