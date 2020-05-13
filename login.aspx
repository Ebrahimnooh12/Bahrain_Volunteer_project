<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Bahrain_Volunteer.login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
    <div class="row">
      <div class="col-sm-9 col-md-7 col-lg-5 mx-auto">
        <div class="card card-signin my-5">
          <div class="card-body">
            <h3 class="card-title font-weight-bold" style="color:#DA4453">Login</h3>
              <hr>
              <asp:Label ID="Note" runat="server" style="color:red"></asp:Label>
              <div class="form-label-group" style="margin-bottom:10px">
                <label for="inputEmail">Email address / Username</label>
                <asp:TextBox class="form-control" ID="username" placeholder="Email address/Username" runat="server"></asp:TextBox>
              </div>
              <div class="form-label-group" style="margin-bottom:10px">
                <label for="inputPassword">Password</label>
                <asp:TextBox class="form-control" ID="Password" TextMode="Password" placeholder="Password" runat="server"></asp:TextBox>
              </div>
              <div class="custom-control custom-checkbox" style="margin-bottom:10px">
                <input type="checkbox" class="custom-control-input" id="customCheck1">
                <label class="custom-control-label" for="customCheck1">Remember password</label>
              </div>
              <asp:Button runat="server" ID="login_btn" Text="login" CssClass="btn text-uppercase" style="background-color:#DA4453;color:#fff;" OnClick="login_Click"  />
              <h5 class='mt-3 mb-1'>Not have account yet?<a href="opportunities.aspx"> Register</a></h5> 
            </div>
        </div>
      </div>
    </div>
  </div>

 
</asp:Content>

