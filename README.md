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


##USE OF LATCH MODULE FOR THE USERS
**Latch does not affect in any case or in any way the usual operations with an account. It just allows or denies actions over it, acting as an independent extra layer of security that, once removed or without effect, will have no effect over the accounts, that will remain with its original state.**

The user needs the Latch application installed on the phone, and follow these steps:

* **Step 1:** Logged in your own account, go to the DotNetNuke page created by the administrator to pair accounts with Latch. The name of the page is set by the administrator so it may vary.

* **Step 2:** From the Latch app on the phone, the user has to generate the token, pressing on **“generate pairing code to add service"** at the bottom of the application.

* **Step 3:** The user has to type the characters generated on the phone into the text box displayed on the web page. Click on **"Pair"** button.

* **Step 4:** Now the user may lock and unlock the account, preventing any unauthorized access.
