<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="AjaxControls.aspx.cs" Inherits="AjaxControls" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<asp:Content ID="Content4" ContentPlaceHolderID="contentHolder" Runat="Server">
    <ajaxToolkit:Accordion ID="Accordion1" runat="server" ContentCssClass="" 
        HeaderCssClass="panelHeader" HeaderSelectedCssClass="selectedPanelHeader" 
        Height="175px" TransitionDuration="250" Width="300px">
        <Panes>
            <ajaxToolkit:AccordionPane ID="AccordionPane1" runat="server" 
                ContentCssClass="" HeaderCssClass="">
                <Header>Panel 1</Header>
                <Content>Content 1</Content>
            </ajaxToolkit:AccordionPane>
            <ajaxToolkit:AccordionPane ID="AccordionPane2" runat="server" 
                ContentCssClass="" HeaderCssClass="">
                <Header>Panel 2</Header>
                <Content>Content 2</Content>
            </ajaxToolkit:AccordionPane>
            <ajaxToolkit:AccordionPane ID="AccordionPane3" runat="server" 
                ContentCssClass="" HeaderCssClass="">
                <Header>Panel 3</Header>
                <Content>Content 3</Content>
            </ajaxToolkit:AccordionPane>
        </Panes>
</ajaxToolkit:Accordion>
    <ajaxToolkit:ComboBox ID="ComboBox1" runat="server">
        <asp:ListItem>Red</asp:ListItem>
        <asp:ListItem>Green</asp:ListItem>
        <asp:ListItem>Blue</asp:ListItem>
    </ajaxToolkit:ComboBox>
    <ajaxToolkit:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0">
        <ajaxToolkit:TabPanel runat="server" HeaderText="TabPanel1" ID="TabPanel1">
        </ajaxToolkit:TabPanel>
    </ajaxToolkit:TabContainer>
</asp:Content>

