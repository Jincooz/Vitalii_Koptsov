Feature: Test DropboxAPI

Scenario Outline: Upload file
Given I don`t have file in disk with <dropbox_filename>
And I set body for upload file to <dropbox_filename>
When I send POST request
Then I receive valid HTTP response code 200

Examples:
| dropbox_filename |
| my.txt           |

Scenario Outline: Get file metadata
Given I upload file to disk with <filename>
And I save it metadata
And I set body for get metadata file from <filename>
When I send POST request
Then I receive valid HTTP response code 200
And Metadata is same as for uploaded file

Examples:
| filename |
| my.txt   |

Scenario Outline: Delete file
Given I have file in disk with <filename>
And I set body for delete file by <filename>
When I send POST request
Then I receive valid HTTP response code 200
And I don`t have file in disk with <filename>

Examples:
| filename |
| my.txt   |