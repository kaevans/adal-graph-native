# adal-graph-native
Calling Microsoft Graph with ADAL library from a native client

## Pre-Requisites
This application requires using a work or school account with Azure AD. It does not support using a personal Microsoft Account or B2C.

## Register in Azure Portal
Go to the Azure Portal, click on **App Registrations**, and choose **New application registration**.  Provide a name, choose **Native Application** as the type, and give a reply URL of `https://localhost`. 

Once created, click the new application registration and choose **Required permissions**. Click the **Add** button and choose the **Microsoft Graph** API. Under permissions, choose **View users' basic profile**, **View users' email address**, and **Access user's data anytime**. 

(./images/permissions.png)[]

##Edit code
In Program.cs, replace the client ID guid with the GUID from your application, and replace the name of your tenant in the authority parameter. Run the sample, you should now be able to acquire a token, the code will query the Graph API, and your last name will be displayed.