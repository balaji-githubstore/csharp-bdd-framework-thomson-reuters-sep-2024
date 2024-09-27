Feature: Login
	In order to manage the employee records
	As a admin
	I would like to access orange hrm portal

Background:
	Given I have browser with OrangeHRM application

Scenario: ValidLogin
	When I enter username as 'Admin'
	And I enter password as 'admin123'
	And I click on login
	Then I should get access to dashboard page with 'Quick Launch'

Scenario Outline: InvalidLogin
	When I enter username as '<username>'
	And I enter password as '<password>'
	And I click on login
	Then I should not get access to dashboard with error as '<expected_error>'
Examples:
	| username | password | expected_error      |
	| john     | john123  | Invalid credentials |
	| peter    | peter243 | Invalid credentials |



