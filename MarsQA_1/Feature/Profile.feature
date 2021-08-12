Feature: Profile
	user should be able to edit all the profile page details

@mytag
Scenario: Add Details to Availability 
Given User is on Profile Tab
And User Clicks on Availabiltytimelink
Then Choose one option from the dropdown.

Scenario: Add Details to AvailabilityHour 
Given User is on Profile Tab
And User Clicks on AvailabiltyHourlink
Then Choose one hour option from the dropdown.

Scenario: Add Details to EarnTarget 
Given User is on Profile Tab
And User Clicks on EarnTargetlink
Then Choose one Target option from the dropdown.

Scenario: Add Description Details
Given User is on Profile Tab
And User Clicks on Descriptiontab
And User adds Description text
Then Savethe description and Verify the details

