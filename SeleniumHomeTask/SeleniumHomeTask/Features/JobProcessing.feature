Feature: Job processing

Scenario Outline: Add new job
	Given a admin on the admin viewJobTitleList page
	And the admin click on Add button
	When the admin saves new job with valid <job_title>, <job_description> and <note>
	Then a job with <job_title> and with <job_description> exist in table

Examples:
 |job_title       |job_description                                   |note                                                           |
 |Student or Intern|Very new, very kind, need to pass practice with us|Need to promote them to our team if he/she good with programing|

Scenario Outline: Delete job
	Given a admin on the admin viewJobTitleList page
	And a job with <job_title> exist in table
	When the admin delete a job with <job_title> through Delete Selected button 
	Then row with <job_title> don`t exist in table

Examples: 
 |job_title        |
 |Student or Intern|