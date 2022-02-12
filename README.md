# MiTTPP Project

This is project made for Methods and techniques of software support testing.

The [Ferivi webshop](https://ferivisport.hr/) is used for the purposes of testing. 

![alt text](https://www.supernova-colosseum.hr//fileadmin/_processed_/4/5/csm_Ferivi_Sport_7085d22855.jpg) 

### Used softwares

- Visual Studio 
- Katalon Recorder
- Katalon Studio
- Mozilla Firefox

## Katalon Recorder & Studio - Selenium test generator
![alt text](https://automated-360.com/wp-content/uploads/2017/10/logo-katalon.png) \
Katalon Recorder is used for recording test cases. Katalon Studio performs test cases execution and allows exporting test cases in C#(WebDriver+NUnit) format suitable for further testing in Visual Studio. Registration is required for using.

Test class should have methods:
  - [SetUp]
  - [TearDown]
  - [Test]

This project is made in Katalon Studio 5.5.3.

## Visual Studio
![alt text](https://magoarcade.org/wp/wp-content/uploads/2020/11/Microsoft-Visual-Studio-logo1.png) \
Requirements for testing cases imported from Katalon Studio:
- NUnit framework (3.13.2)
- Selenium WebDriver (4.1.0)
- Selenium Support(4.1.0)
- Nunit3 Test Adapter (4.1.0)
- Selenium WebDriver – Gecko Driver (0.30.0.1)

This project is made in Visual Studio 2019.

## Testing process
- Prepare all needed softwares in advance.
- Think of test cases that would be suitable for testing.
- Make documentation for test cases.
- Open Mozilla Firefox web browser and install Katalon Recorder browser plugin
- Start Katalon Recorder
- Click on "Record" button in main menu for starting recording session.
- Do steps in browser as you wish your test case goes.
- When finished with test case, stop recording session.
- Check steps and run script.
- Export script in C#(WebDriver+Nunit) format.
- Run Visual Studio and create new C# Unit Test (.NET Framework) project
- Via Project->Manage NuGet Packages add:
  - NUnit framework (3.13.0)
  - Selenium WebDriver (3.141.0)
  - Selenium Support(3.141.0)
  - Nunit3 Test Adapter (3.17.0)
  - Selenium WebDriver – Gecko Driver (0.28.0)
- Check installed packages.
- In UnitTest class add previously exported tests in C#(WebDriver+Nunit) format.
- Check if class has methods:
  - [SetUp]
  - [TearDown]
  - [Test]
- If neccesary fill in test (example: declaration of random variables)
- Click on Build -> Build Solution
- Click on Test -> Test Explorer
- Run tests

## Test Cases

- Login and Logout
  - this case tests the site's behavior when logging in to an already registered user and logging out

| Step | Action |
| ------ | ------ |
| Preconditions | User has profile |
| 1 | Go to URL [https://ferivisport.hr/]|
| 2 | Click on "user" |
| 3 | Fill in email and password |
| 4 | Submit |
| 5 | Click on "user" |
| 6 | Click on "Odjavi me" |

- Subscribe to newsletter
  - this case tests the option of subscribing to newsletter providing an email

| Step | Action |
| ------ | ------ |
| Preconditions | User has profile |
|   | User is logged in |
| 1 | Find element "newsletter" |
| 2 | Fill in email |
| 3 | Submit |

- Find all footwear size EU43
  - this case tests the filter option, choosing filters "footwear" and "size=43"

| Step | Action |
| ------ | ------ |
| 1 | Filter to "footwear" |
| 2 | Filter to "size=43" |

- Find every Adidas Originals men product
  - this case tests the filter option, choosing filters "brand_adidasoriginals" and "men"

| Step | Action |
| ------ | ------ |
| 1 | Open "men" section|
| 2 | Filter to "brand_adidasoriginals" |


- Browse and add product to cart
  - this case tests browsing, choosing product, choosing size and adding to cart

| Step | Action |
| ------ | ------ |
| 1 | Select item|
| 2 | Choose sizing |
| 3 | Add to cart|

- Remove product from cart
  - this case tests editing the cart and removing top item in it

| Step | Action |
| ------ | ------ |
| Preconditions | There are products in cart |
| 1 | Click on "cart"|
| 2 | Click on "Uredite košaricu" |
| 3 | Click on "Uklonite proizvod"|

- Check cart and increase number of product
  - this case tests cart option and increasing number of product

| Step | Action |
| ------ | ------ |
| Preconditions | There are products in cart |
| 1 | Click on "cart"|
| 2 | Click on "Uredite košaricu" |
| 3 | Click on plus sign for number of products|

- Fill cart and proceed
  - this case tests adding two items in cart, checking cart and proceeding to payment details

| Step | Action |
| ------ | ------ |
| 1 | Select item|
| 2 | Choose sizing |
| 3 | Add to cart|
| 4 | Select item|
| 5 | Choose sizing |
| 6 | Add to cart|
| 7 | Click on "cart"|
| 8 | Click on "Uredite košaricu" |
| 9 | Click on "Završite kupovinu"|

- Change delivery address
  - this case tests editing user information, specifically changing delivery address

| Step | Action |
| ------ | ------ |
| Preconditions | User has profile |
|   | User is logged in |
|   | Delivery address is previously added |
| 1 | Click on "user"|
| 2 | Click on "Uredi" for "Adresa naplate" |
| 3 | Fill in with new address information|
| 4 | Submit|


- Find locations
  - this case maneuvers the page to information about store locations

| Step | Action |
| ------ | ------ |
| 1 | Click on "O NAMA" |
| 2 | Click on "Lokacije" |

## How to use?
Download [Visual Studio](https://visualstudio.microsoft.com/downloads/)\
Download [Katalon Recorder](https://www.katalon.com/katalon-recorder-ide/) * \
Download [Katalon Studio](https://www.katalon.com/katalon-studio/) * \
Download [Mozilla Firefox](https://www.mozilla.org/hr/firefox/new/) * \
Download [code](https://github.com/AmelaVorgic/MiTTPP-Projekt) and open [MiTTPP-Projekt.sln](https://github.com/AmelaVorgic/MiTTPP-Projekt/blob/main/MiTTPP-Projekt.sln) in Visual Studio. 


*not necessary for code included in project, required only to perform new tests



## Author
[@AmelaVorgic](https://github.com/AmelaVorgic)
