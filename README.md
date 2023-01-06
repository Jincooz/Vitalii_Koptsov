# Vitalii_Koptsov
<h1> WebAPIs Bascis Homework </h1>
<h2> Instal From GitHub </h2>
Clone this repository to your mashine</br></br>

```
git clone https://github.com/Jincooz/Vitalii_Koptsov.git
```
Go to cloned repository
```
cd Vitalii_Koptsov
```
Checkout to WebAPI branch</br>
```
git checkout origin/WebAPI
```
<h2> Run tests </h2>
<h3>You need instaled dotnet 6.0.0 to run tests.</h3>

Go to WebAPIsBascisHomework folder</br></br>

```
cd WebAPIsBascisHomework
```
 You need obtain an access token by <a href="https://www.dropbox.com/developers/apps/create">creating a Dropbox API</a> app and following the steps in the "Generate an access token" section of the <a href="https://www.dropbox.com/developers/documentation/http/overview">Dropbox API documentation</a>.</br>
<p>And need to set it to the Token field in dictionary in WebAPIsBascisHomework/Configuration.cs.</br>

 ```
 vim WebAPIsBascisHomework/Configuration.cs
 ```

Build solution using dotnet.exe</br>

```
dotnet build  
```
<h3>Run tests</h3>

```
dotnet test  
```

You get some info about test results from console</br>
<h2> Get Allure report</h2>
<h3>You need instaled Allure plugin to get report</h3>
<a href="https://github.com/allure-framework/allure2">Here</a> you can find installation guide</br>
For easier installation on Ubuntu you can use <a href = "https://stackoverflow.com/a/65717867/">this answer</a></br>
From SeleniumHomeTask folder with sln file go to Debug files</br>

```
cd WebAPIsBascisHomework/bin/Debug/net6.0/
```

Generate allure report in allure-report folder in same directory</br>

```
allure generate allure-results --clean -o allure-report
```

Now, you can open your report using 'allure open' comand</br>

```
allure open allure-report
```