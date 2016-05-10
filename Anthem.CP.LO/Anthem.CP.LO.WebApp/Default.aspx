<%@ Page Title="User Login" Language="C#" MasterPageFile="~/CPLO.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Anthem.CP.LO.WebApp.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div class="col-md-8">
        <form class="form-horizontal" runat="server" id="sample">



            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h3 class="panel-title">Login</h3>
                </div>

                <div class="panel-body">



                    <div id="panelErrorMessages" class="alert alert-danger" role="alert">
                        <span class="glyphicon glyphicon-exclamation-sign" aria-hidden="true"></span>
                        <span class="sr-only">Error:</span>
                        Please enter valid email and password.
                    </div>
                    <div class="form-group">
                        <label for="inputEmail" class="control-label col-xs-2">Email</label>
                        <div class="col-xs-10">

                            <input type="email" id="txtEmail" class="form-control" />

                        </div>
                    </div>
                    <div class="form-group">
                        <label for="inputPassword" class="control-label col-xs-2">Password</label>
                        <div class="col-xs-10">
                            <input type="password" id="txtPassword" class="form-control" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-xs-offset-2 col-xs-10">


                            <div class="checkbox">
                                <label>
                                    <asp:CheckBox ID="CheckBox1" runat="server" />
                                    Remember me</label>
                            </div>

                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-xs-offset-2 col-xs-10">
                            <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-primary" Text="Login"></asp:Button>
                            <a href="Registration.aspx" class="navbar-link">New User?</a>
                        </div>
                    </div>
                </div>

            </div>
        </form>
    </div>
    <script type="text/javascript">

        $(document).ready(function () {
            $("#LoginNav").addClass("active");
            $("#panelErrorMessages").hide();

        });
        $("#<%= btnSubmit.ClientID%>").click(function (e) {
            //var email = $('#txtEmail').val();
            var isValid = true;
            $('input').each(function () {
                if ($.trim($(this).val()) == '') {
                    isValid = false;
                    $("#panelErrorMessages").show();
                    $(this).css({

                        "border": "1px solid red",

                        "background": "#FFCECE"

                    });

                    if (isValid == false) {
                        e.preventDefault();
                    }
                }

            });
        });
    </script>




</asp:Content>
