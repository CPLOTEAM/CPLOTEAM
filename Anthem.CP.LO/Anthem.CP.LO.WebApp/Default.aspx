<%@ Page Title="" Language="C#" MasterPageFile="~/CPLO.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Anthem.CP.LO.WebApp.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $("#LoginNav").addClass("active");
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div class="col-md-8">
        <form class="form-horizontal">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h3 class="panel-title">Login</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <label for="inputEmail" class="control-label col-xs-2">Email</label>
                        <div class="col-xs-8">
                            <input type="email" class="form-control" id="inputEmail" placeholder="Email" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="inputPassword" class="control-label col-xs-2">Password</label>
                        <div class="col-xs-8">
                            <input type="password" class="form-control" id="inputPassword" placeholder="Password" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-xs-offset-2 col-xs-10">
                            <div class="checkbox">
                                <label>
                                    <input type="checkbox" />
                                    Remember me</label>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-xs-offset-2 col-xs-10">
                            <button type="submit" class="btn btn-primary">Login</button>
                        </div>
                    </div>
                </div>
            </div>
        </form>
    </div>
</asp:Content>
