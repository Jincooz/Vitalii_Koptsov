Feature: Job processing

#Scenario: User log in
#	Given visitor opens the login page
#	And visitor enters in username field username from orange-login-error
#	And visitor enters in password field password from orange-login-error
#	When visitor click on login button
#	Then visitor redirected to dashboard page

Scenario: Add new job: Student or Intern
	Given a admin on the dashboard page
	When the admin click into Admin menu item
	And the admin is redirected to the admin viewSystemUsers page
	When the admin click on Job ToppBar Menu Item
	And the DropDown Menu shows
	When the admin click on Job Titles DropDown Menu Item
	And the admin is redirected to the admin viewJobTitleList page
	When the admin click on Add button
	And the admin is redirected to admin saveJobTitle page
	And the admin enters 'Student or Intern' into Job Title field
	And the admin enters 'Very new, very kind, need to pass practice with us' into Job Description field
	And the admin enters 'Need to promote them to our team if he/she good with programing' into Note field
	When the admin click on Save button
	And the admin is redirected to the admin viewJobTitleList page
	Then row with 'Student or Intern' as Job Title and with 'Very new, very kind, need to pass practice with us' as Job Description needs to be in table

Scenario: Delete user from list of Job Titles
	Given a admin on the admin viewJobTitleList page
	And the admin checks checkbox coresponding to 'Student or Intern' Job Title
	When the admin click Delete Selected
	And pop up window pops up
	And the admin click 'Yes, Delete'
	And table reload
	Then row with 'Student or Intern' as Job Title don`t exist in table