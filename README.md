# QATestProject
SDET Test Project

This is a simple test project designed for you to demonstrate your technical skills in C# .NET MVC as an SDET tester. The setup for this test is pretty simple. 
SPIE has a section of our website that displays the profiles of various SPIE and SPIE-affiliated people. This code is the initial development of that profiles section. Unfortunately, it has some bugs and missing functionality.

A project has been added to the solution for unit and functional testing.


# Your task
Add a new project or use the Profiles.Business.Tests project for performing the unit and/or functional tests.
1. Create functional tests for the Profiles.Business assembly ProfileCollection class.

2. Create at least one unit test for the Profiles.Business assembly.
   - Identify and write tests that should cover functionality provided in the Profiles.Business assembly for the WebApplication web-site.

3. Evaluate code and determine what would be required to test using moq.
   a. Write a test using moq.

Add a new project or use the Profiles.Business.Tests project for performing the End-to-End/UI tests.
4. End-to-End/UI tests for the WebApplication.
   a. For these tests, download Selenium.WebDriver Nuget Package (you may include additional selenium packages as needed or preferred.  As a minimum, testing should support Chrome web-browser).
   b. Identify tests that should cover the following UI areas and functionality (and be able to catch the known bugs that are code-related).
		-	Who's using SPIE Profiles?
		-	Home Page: Profile Search
		-	Home Page: Profile Search Results



# How to get this project
Pull down a zip of this by clicking the "Clone or download" link on the upper right of this repo, and select "Download Zip". 
Unzip into your "My Documents" folder, and open the WebApplication.sln with visual studio. Build the solution, then click the "IIS Express" at the top to run the website.


# Known Issues
* On the home page, the search profiles text box doesn't line up with the magnifying glass.
* When clicking on a SPIE Profile Name link, it's supposed to send you to the profile information for that particular person. It is currently always displaying Jim Bob's profile.
* An individual profile can be accessed by using the following URL formats: 
		/profiles/view/{ID}
		
* The Profile Search on the home page submits search text information to the server and the page is refreshed to include search results
* An individual profile can be accessed by using the following URL formats: 
		/profiles/view/{ID}?Filter={searchtext}
	-	When using the filtered Uri, if non-numeric characters are entered for the ID, an exception is thrown.


# How to submit this
1. Create a new private repo in GitHub
2. Install the Github extension for visual studio (in visual studio, click tools->"extensions and updates" and search for "Github Extension for Visual Studio")
3. Connect to GitHub and the repo with Visual studio. Use the [extension's website](https://visualstudio.github.com/) to see screenshots of how to connect
4. Update your README.md file to specify what bug fixes and functionality adds you did, as well as any new instructions for set up
5. Push your modified code to your private repo
6. Send your SPIE contact an invite to the repo
