    $(function () {
        $('.form-delete-cart').submit(function (e) {
            e.preventDefault();

            var form = $(this);
            var url = form.attr('action');

            $.ajax({
                type: 'POST',
                url: url,
                data: form.serialize(),
                success: function (response) {
                    if (response.success) {
                        console.log("Hello");
                        location.reload();
                    }
                }
            });
        });
    });
