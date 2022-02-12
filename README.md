# MiTTPP Project

This is project made for Methods and techniques of software support testing.

The [Ferivi webshop](https://ferivisport.hr/) is used for the purposes of testing. 

![alt text](https://www.supernova-colosseum.hr//fileadmin/_processed_/4/5/csm_Ferivi_Sport_7085d22855.jpg) 

### Used softwares

- Visual Studio 
- Katalin Recorder
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
- Subscribe to newsletter
  - this case tests the option of subscribing to newsletter providing an email
- Find all footwear size EU43
  - this case tests the filter option, choosing filters "footwear" and "size=43"
- Find every Adidas Originals men product
  - this case tests the filter option, choosing filters "brand_adidasoriginals" and "men"
- Browse and add product to cart
  - this case tests browsing, choosing product, choosing size and adding to cart
- Remove product from cart
  - this case tests editing the cart and removing top item in it
- Check cart and increase number of product
  - this case tests cart option and increasing number of product
- Fill cart and proceed
  - this case tests adding two items in cart, checking cart and proceeding to payment details
- Change delivery address
  - this case tests editing user information, specifically changing delivery address
- Find locations
  - this case maneuvers the page to location information

## How to use?
Download [Visual Studio](https://visualstudio.microsoft.com/downloads/)\
Download [Katalon Recorder](https://www.katalon.com/katalon-recorder-ide/) * \
Download [Katalon Studio](https://www.katalon.com/katalon-studio/) * \
Download [Mozilla Firefox](https://www.mozilla.org/hr/firefox/new/) * \
Download [code](https://github.com/AmelaVorgic/MiTTPP-Projekt) and open [MiTTPP-Projekt.sln](https://github.com/AmelaVorgic/MiTTPP-Projekt/blob/main/MiTTPP-Projekt.sln) in Visual Studio. 


*not necessary for code included in project, required only to perform new tests



## Author
- [@AmelaVorgic](https://github.com/AmelaVorgic)
