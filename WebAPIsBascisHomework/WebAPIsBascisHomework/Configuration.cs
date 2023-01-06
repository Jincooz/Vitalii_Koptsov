using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIsBascisHomework
{
    internal class Configuration
    {
        public static string CreateFolderApiUrl => "https://api.dropboxapi.com/2/files/create_folder_v2";
        public static string DeleteApiUrl => "https://api.dropboxapi.com/2/files/delete_v2";
        public static string GetMetadataApiUrl => "https://api.dropboxapi.com/2/files/get_metadata";
        public static string UploadApiUrl => "https://content.dropboxapi.com/2/files/upload";
        public static string ListFolderApiUrl => "https://api.dropboxapi.com/2/files/list_folder";
        public static string Token => "sl.BWbQXy0E0OsBJr1oJscwCa886oNQEw2kDby11wJwFwucFwmd-qvV2lGXulPe7wl-FHu6uyJ-BL8X1ZB8ncpvb-TuLrvx0wOg1Xhq9bQsUurfO_iGyxOzmF36xxG5Q4WwaTBpyOI";
    }
}
