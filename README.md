# Vitalii_Koptsov
<h2> Selenium Home Task </h2>
<h3> Instal From GitHub </h3>
Clone this repository to your mashine</br></br>

```
git clone https://github.com/Jincooz/Vitalii_Koptsov.git
```
Go to cloned repository
```
cd Vitalii_Koptsov
```
Checkout to WebUI branch</br>
```
git checkout origin/WebUI
```
<h3> Run tests </h3>
<h4>You need instaled dotnet 6.0.0 to run tests.</h4>
For test using ChromeDriver, you can change it in PageObjectStaticFabric.cs file</br>
Go to SeleniumHomeTask folder</br></br>

```
cd SeleniumHomeTask
```
Build solution using dotnet.exe</br>

```
dotnet build  
```
Run tests</br>
```
dotnet test  
```
You get some info about test result from console</br>
<h3> Get Allure report</h3>
<h4>You need instaled Allure plugin to get report</h4>

For Windows, Allure is available from the Scoop CLI installer.</br>

From SeleniumHomeTask folder with sln file go to Debug files</br>

```
cd SeleniumHomeTask/bin/Debug/net6.0/
```
Generate allure report in allure-report folder in same directory</br>
```
allure generate allure-results --clean -o allure-report
```
Now, you can open your report using 'allure open' comand</br>
```
allure open allure-report
```