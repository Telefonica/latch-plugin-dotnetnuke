#LATCH INSTALLATION GUIDE FOR DOTNETNUKE


##PREREQUISITES
* DotNetNuke version 7.

* .Net Framework version 4.0 or higher.

* To get the **"Application ID"** and **"Secret"**, (fundamental values for integrating Latch in any application), it’s necessary to register a developer account in [Latch's website](https://latch.elevenpaths.com). On the upper right side, click on **"Developer area"**.


##DOWNLOADING THE DOTNETNUKE PLUGIN
 * When the account is activated, the user will be able to create applications with Latch and access to developer documentation, including existing SDKs and plugins. The user has to access again to [Developer area](https://latch.elevenpaths.com/www/developerArea), and browse his applications from **"My applications"** section in the side menu.

* When creating an application, two fundamental fields are shown: **"Application ID"** and **"Secret"**, keep these for later use. There are some additional parameters to be chosen, as the application icon (that will be shown in Latch) and whether the application will support OTP  (One Time Password) or not. For DotNetNuke the OTP must be disabled.

* From the side menu in developers area, the user can access the **"Documentation & SDKs"** section. Inside it, there is a **"SDKs and Plugins"** menu. Links to different SDKs in different programming languages and plugins developed so far, are shown.

##INSTALLING THE PLUGIN IN DOTNETNUKE
* Go to **"Host->Extensions"**, then press **"Install Extensions Manager"**, upload the zip with Latch plugin.

* Read the plugin information and the license agreement, then click on **"Accept License"**.


##CONFIGURING THE INSTALLED PLUGIN
* Go back to Extensions page, check that the Latch module is on the list.

* Click on **"Pages->Add New Page"**, introduce a name, title and URL. Set as parent page to **"None Specified"** and give view permissions to registered users.

* Click on **"Modules->Add new module"**, search for Latch Plugin on the list and drag and drop it into the new page you just created.

* Open **"Edit Mode"**, place the mouse over the Latch module and go into **"Settings"**.

* Click on **"Latch Plugin Settings"** and introduce there the **"AppID"** and **"AppSecret"** you got from Latch's page.


##UNINSTALLING THE PLUGIN IN DOTNETNUKE
* Go to **"Host-Extension"**. Plugin "Latch" appears in the list. Press on **"Uninstall"** on the right side. Check the **"Delete files?"** option in the end of the new window. Press **"Uninstall Package"** button.

