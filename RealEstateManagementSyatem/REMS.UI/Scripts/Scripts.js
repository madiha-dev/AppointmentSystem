function ValidateNumber(e) {
    var evt = (e) ? e : window.event;
    var charCode = (evt.keyCode) ? evt.keyCode : evt.which;
    if (charCode > 31 && (charCode < 48 || charCode > 57)) {
        return false;
    }
    return true;
};
function ValidateLetter(e) {
    var evt = (e) ? e : window.event;
    var charCode = (evt.keyCode) ? evt.keyCode : evt.which;
    if (charCode > 31 && (charCode < 97 || charCode > 122) && (charCode < 65 || charCode > 90)) {
        return false;
    }
    return true;
};
$(function () {
    $('#selectDate').click(function () {
        var $datepicker = $("#datepicker-input");
        $datepicker.datepicker({
            beforeShow: function (input, inst) {
                $(input).datepicker('setDate', new Date());
            }
        });
        $datepicker.datepicker("show");
    });
});