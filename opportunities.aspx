<%@ Page Title="Opportunities" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="opportunities.aspx.cs" Inherits="Bahrain_Volunteer.opportunities" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div class="container form">
         <div class="headers">
             <h3>Volunteer in the Campaign to Combat Coronavirus (COVID-19)</h3>
             <div class="details">
                 <p>Join us in efforts to contain the Coronavirus (COVID-19) by volunteering through the many opportunities provided by the Kingdom’s Public Awareness Campaign to Combat COVID-19.</p>          
                 <p>The campaign has introduced a variety of activities and services to bring together citizens and residents in cooperation to ensure the Kingdom remains a safe and healthy community for all.</p> 
                 <p>Complete the form below, specifying which areas you would be interested in volunteering in.</p>   
             </div>
         </div>
         <div class="hide" id="mess" runat="server"></div>
         <div class="register">

             <div class="form-group">
                <label for="Email">Email address</label>
                <asp:TextBox class="form-control" ID="email" TextMode="Email" placeholder="Email" runat="server"></asp:TextBox>
                <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
              </div>
             
              <div class="form-group">
                <label for="firstname">First Name</label>
                <asp:TextBox class="form-control" ID="firstname" placeholder="First Name" runat="server"></asp:TextBox>
              </div>
             
              <div class="form-group">
                <label for="lastname">Last Name</label>
                <asp:TextBox class="form-control" ID="lastname" placeholder="lastname" runat="server"></asp:TextBox>
              </div>

              <div class="form-group">
                <label for="cpr">CPR</label>
                <asp:TextBox class="form-control" ID="cpr" TextMode="Number" placeholder="CPR" runat="server"></asp:TextBox>
              </div>

              <div class="form-group">
                <label for="specialty">Specialty</label>
                <asp:TextBox class="form-control" ID="specialty" placeholder="Specialty" runat="server"></asp:TextBox>
              </div>

              <div class="form-group">
                <label for="education">Education</label>
                <asp:TextBox class="form-control" ID="education" placeholder="Education" runat="server"></asp:TextBox>
              </div>

              <div class="form-group">
                <label for="tel">TEL</label>
                <asp:TextBox class="form-control" ID="tel" TextMode="Number" placeholder="TEL" runat="server"></asp:TextBox>
              </div>
             
             <div class="form-group">
                <label for="password">Password</label>
                <asp:TextBox class="form-control" ID="Password" TextMode="Password" placeholder="Password" runat="server"></asp:TextBox>
              </div>

             <div class="form-group">
                <label for="cpassword">Confirm Password</label>
                <asp:TextBox class="form-control" ID="cpassword" TextMode="Password" placeholder="Confirm Password" runat="server"></asp:TextBox>
              </div>
        
             <div class="form-group justify-content-center">
                 <asp:Button runat="server" ID="submit" Text="Submit" CssClass="btn btn-default" OnClick="submit_Click" />
             </div>

         </div>
     </div>
</asp:Content>
