<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataTableFoto.aspx.cs" Inherits="DataTableExplicacion.Vista.DataTableFoto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <link href="../bootstrap-5.0.2-dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../Recursos/DataTables/datatables.css" rel="stylesheet" />

    <title>DataTables</title>

</head>
<body>
    <form id="form1" runat="server">

        <div class="container my-2">
            <div class="row flex-shrink-1">
                <table id="DataTableExplicacion" class="table table-striped" style="width: 100%">
                    <thead>
                        <tr>
                            <th>Foto</th>
                            <th>Documento</th>
                            <th>Nombre</th>
                            <th>Apellido</th>
                            <th>Ciudad</th>
                            <th>Telefono</th>
                            <th>Opciones</th>
                        </tr>
                    </thead>
                    <tbody></tbody>
                </table>
            </div>
        </div>

        <script src="../Recursos/jQuery-3.6.0/jquery-3.6.0.js"></script>
        <script src="../Recursos/DataTables/datatables.js"></script>
        <script src="../bootstrap-5.0.2-dist/js/bootstrap.min.js"></script>
        <script src="../bootstrap-5.0.2-dist/js/bootstrap.bundle.min.js"></script>
        <script src="../Recursos/js/TablaFoto.js"></script>
    </form>
</body>
</html>
