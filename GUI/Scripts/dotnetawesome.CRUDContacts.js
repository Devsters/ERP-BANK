$(document).ready(function () {

    //Populate Contact
    LoadContacts();
});
function LoadContacts() {
    $('#update_panel').html('Loading Data...');

    $.ajax({
        url: '/accounts/GetContacts',
        type: 'GET',
        dataType: 'json',
        success: function (d) {
            if (d.length > 0) {
                var $data = $('<table></table>').addClass('table table-responsive table-striped');
                var header = "<thead><tr><th>Contact Person</th><th>Contact No</th><th>Country</th><th>State</th><th></th></tr></thead>";
                $data.append(header);

                $.each(d, function (i, row) {
                    var $row = $('<tr/>');
                    $row.append($('<td/>').html(row.id));
              
                    $row.append($('<td/>').html("<a href='/home/Save/" + row.ContactID + "' class='popup'>Edit</a>&nbsp;|&nbsp;<a href='/home/Delete/" + row.id + "' class='popup'>Delete</a>"));
                    $data.append($row);
                });

                $('#update_panel').html($data);
            }
            else {
                var $noData = $('<div/>').html('No Data Found!');
                $('#update_panel').html($noData);
            }
        },
        error: function () {
            alert('Error! Please try again.ff');
        }
    });

}