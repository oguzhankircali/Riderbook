var RB = {
    /* ShowMessage: -1:Error 0:Info 1:Success */
    ShowMessage: function (type, message, title) {

        if (title == null) title = 'Riderbook';

        switch (type) {
            case -1:
                toastr.error(message, title);
                break;
            case 0:
                toastr.info(message, title);
                break;
            case 1:
                toastr.success(message, title);
                break;
        }
    },

    ShowModal: function () {
        toastr.success('I hope!');
    },

    Post: function () {
        $.post('/Home/Index2', { data: 'yahoo' }, '', 'GET');
    },

    Post2: function () {

        var url = '@Url.Action("Index2", "Home")';


        var jqxhr = $.post("/Home/Index2", function () {
            alert("success");
        })
  .done(function () {
      toastr.success("second success");
  })
  .fail(function () {
      toastr.error("error");
  })
  .always(function () {
      toastr.info("finished");
  });
    }
}