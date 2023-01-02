# Vitalii_Koptsov
<h1> Selenium Home Task </h1>
<h2> Instal From GitHub </h2>
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
<h2> Run tests </h2>
<h3>You need instaled dotnet 6.0.0 to run tests.</h3>
By defoult I using ChromeDriver, you can change it in Hooks.cs file</br>
Go to SeleniumHomeTask folder</br></br>

```
cd SeleniumHomeTask
```
Build solution using dotnet.exe</br>

```
dotnet build  
```
<h3>Run tests</h3>
Additionaly you need manualy install driver for your browser and set directory where driver placed to PATH</br>
Guide how it do and links to download driver you can found <a href="https://www.selenium.dev/documentation/webdriver/getting_started/install_drivers/#3-the-path-environment-variable">here</a></br>
If you don`t want to add driver directory to PATH you can simply place dowloaded driver from the link above into SeleniumHomeTask/bin/Debug/net6.0/ </br>

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