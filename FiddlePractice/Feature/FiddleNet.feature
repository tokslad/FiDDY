Feature: FiddleNet
	As a user of Dot Fiddle I want to carry out 
	some functions on the site

@mytag
Scenario: Functional
	Given I navigate to "https://dotnetfiddle.net/"
	When I click on getting started
	And I click on back editor
	Then I should see "Hello World" is displayed on the landing page output