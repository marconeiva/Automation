Feature: Search

@mytag
Scenario: Search with test data Testing
	Given Launch Chrome browser
	And Navigate to code project web site
	When Click on Search our articles button
	When Input test data Testing in textfield
	And Click on Search Button 
	Then results should be visible and browser should close.
