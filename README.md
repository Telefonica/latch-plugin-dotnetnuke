###LATCH DOTNETNUKE 7 PLUGIN -- INSTALLATION GUIDE###

####PREREQUISITES####

* DotNetNuke version 7.

* .Net Framework 4.0 or higher.

* To get the "Application ID" and "Secret", (fundamental values for integrating Latch in any application), it’s necessary to register a developer account in Latch's website: https://latch.elevenpaths.com. On the upper right side, click on "Developer area".

####INSTALLING THE MODULE IN DOTNETNUKE 7.####

1. Go to Host->Extensions, then click on the button Install Extensions Manager, upload the zip the Latch plugin.

2. Read the plugin information and the license agreement, then click on 'Accept License'.

3. Go back to Extensions page, check that the Latch module is on the list.

4. Click on Pages->Add New Page, introduce a name and title related to 'Latch' or 'Security', and 'latch' as the URL. Set as parent page 'Any parent' and give view permissions to registered users.

5. Click on Modules->Add new module, search for Latch Plugin on the list and drag it to the new page you just created.

6. Open Edit Mode, put your mouse over the Latch module and go into 'configuration'.

7. Click on 'Latch Plugin Settings' and introduce there the AppId and AppSecret you got from latch's page.
