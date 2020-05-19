﻿var content = {
    init: function () {
        content.registerEvents();
    },
    registerEvents: function () {
        $('.ui-btn-active').off('click').on('click', function (e) {
            e.preventDefault();
            var btn = $(this);
            var id = btn.data('id');
            $.ajax({
                url: "/Admin/Content/ChangeStatus",
                data: { id: id },
                dataType: "json",
                type: "POST",
                success: function (response) {
                    console.log(response);
                    if (response.status == true) {
                        btn.text('Active');
                    }
                    else {
                        btn.text('Inactive');
                    }
                }
            });
        });
    }
}
content.init();