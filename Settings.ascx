<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Settings.ascx.cs" Inherits="ElevenPaths.Modules.LatchDotNetNukePlugin.Settings" %>
<%@ Register TagPrefix="dnn" TagName="label" Src="~/controls/LabelControl.ascx" %>

	<h2 id="dnnSitePanel-BasicSettings" class="dnnFormSectionHead"><a href="" class="dnnSectionExpanded"><%=LocalizeString("BasicSettings")%></a></h2>
	<fieldset>
        <div class="dnnFormItem">
            <dnn:Label ID="lblAppId" Text="AppID" runat="server" /> 
 
            <asp:TextBox ID="txtAppId" runat="server" />
        </div>
        <div class="dnnFormItem">
            <dnn:label ID="lblAppSecret" Text="AppSecret" runat="server" />
            <asp:TextBox ID="txtAppSecret" runat="server" />
        </div>
    </fieldset>