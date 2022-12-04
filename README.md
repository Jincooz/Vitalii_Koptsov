# Vitalii_Koptsov
<h2> Selenium Home Task </h2>
<h3> Instal From GitHub </h3>
Clone this repository to your mashine</br></br>

```
git clone https://github.com/Jincooz/Vitalii_Koptsov.git
```
Checkout to WebUI branch</br>
```
git checkout origin/WebUI
```
<h3> Run tests </h3>
Go to SeleniumHomeTask folder</br></br>

```
cd Vitalii_Koptsov/SeleniumHomeTask
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