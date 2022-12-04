Feature: Job processing

Scenario: Add new job
	Given a admin on the admin viewJobTitleList page
	And the admin click on Add button
	And the admin enters 'Student or Intern' into Job Title field
	And the admin enters 'Very new, very kind, need to pass practice with us' into Job Description field
	And the admin enters 'Need to promote them to our team if he/she good with programing' into Note field
	When the admin click on Save button
	Then the admin is redirected to the admin viewJobTitleList page
	And row with 'Student or Intern' as Job Title and with 'Very new, very kind, need to pass practice with us' as Job Description exist in table

Scenario: Delete job
	Given a admin on the admin viewJobTitleList page
	And Job Title 'Student or Intern' exist in table
	And the admin checks checkbox coresponding to 'Student or Intern' Job Title
	And the admin scrolls up to top
	When the admin clicks Delete Selected and ensure it in pop up window
	Then row with 'Student or Intern' as Job Title don`t exist in table