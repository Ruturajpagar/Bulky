$(document).ready(function () {
    loadDataTable();    
})

function loadDataTable() {
    $('#tblData').DataTable({
        "ajax": '/product/admin/getall'
    });
}