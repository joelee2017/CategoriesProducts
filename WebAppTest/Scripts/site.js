﻿function readURL(input, img) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            img.attr("src", e.target.result);
        };
        reader.readAsDataURL(input.files[0]);
    }
}