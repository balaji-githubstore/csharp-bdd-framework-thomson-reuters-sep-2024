#Feature: Employee
#	In order to manage the employee records
#	As a admin
#	I want to add, edit, delete the employee records
#
#Scenario: AddValidEmployeeRecord
#	Given I have browser with OrangeHRM application
#	When I enter username as 'Admin'
#	And I enter password as 'admin123'
#	And I click on login
#	And I click on PIM menu
#	And I click on Add Employee menu
#	And I fill the new employee details
#		| firstname | middlename | lastname |
#		| john      | w          | wick     |
#	And I click on save
#	Then I should see the profile name as 'john wick'
#	And I should verify the employee full name in the text field
#
#Scenario: AddValidEmployeeRecord2
#	Given I have browser with OrangeHRM application
#	When I enter username as 'Admin'
#	And I enter password as 'admin123'
#	And I click on login
#	And I click on PIM menu
#	And I click on Add Employee menu
#	And I fill the new employee details
#		| firstname | middlename | lastname |
#		| peter      | w          | kevin     |
#	And I click on save
#	Then I should see the profile name as 'peter kevin'
#	And I should verify the employee full name in the text field

