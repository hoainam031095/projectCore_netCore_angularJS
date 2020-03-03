﻿/*
 *  Document   : login.js
 *  Author     : pixelcave
 */
var Login = function () {
    var e = function (e, r, s) {
        e.slideUp(250),
            r.slideDown(250, function () {
                $("input").placeholder()
            }),
            window.location = s ? "#" + s : "#"
    };
    return {
        init: function () {
            var r = $("#form-login"),
                s = $("#form-reminder"),
                o = $("#form-register");
            $("#link-register-login").click(function () { e(r, o, "register") }),
                $("#link-register").click(function () { e(o, r, "") }),
                $("#link-reminder-login").click(function () { e(r, s, "reminder") }),
                $("#link-reminder").click(function () { e(s, r, "") }),

                "#register" === window.location.hash && (r.hide(), o.show()),
                "#reminder" === window.location.hash && (r.hide(), s.show()),

                $("#form-login").validate({
                    errorClass: "help-block animation-slideDown",
                    errorElement: "div",
                    errorPlacement: function (e, r) { r.parents(".form-group > div").append(e) },
                    highlight: function (e) {
                        $(e).closest(".form-group").removeClass("has-success has-error").addClass("has-error"),
                            $(e).closest(".help-block").remove()
                    },
                    success: function (e) {
                        e.closest(".form-group").removeClass("has-success has-error"),
                            e.closest(".help-block").remove()
                    },
                    rules: {
                        "login-email": {
                            required: !0,
                        },
                        "login-password": {
                            required: !0,
                            minlength: 1
                        },
                        messages: {
                            "login-email": "Xin mời nhập tài khoản hoặc địa chỉ email",
                            "login-password": {
                                required: "Xin mời nhập mật khẩu",
                                minlength: "Mật khẩu tối thiểu là 5 ký tự"
                            }
                        }
                    }
                }),

                $("#form-reminder").validate({
                    errorClass: "help-block animation-slideDown",
                    errorElement: "div",
                    errorPlacement: function (e, r) {
                        r.parents(".form-group > div").append(e)
                    },
                    highlight: function (e) {
                        $(e).closest(".form-group").removeClass("has-success has-error").addClass("has-error"),
                            $(e).closest(".help-block").remove()
                    },
                    success: function (e) {
                        e.closest(".form-group").removeClass("has-success has-error"),
                            e.closest(".help-block").remove()
                    },
                    rules: { "reminder-email": { required: !0, email: !0 } },
                    messages: { "reminder-email": "Xin mời nhập địa chỉ email" }
                }),

                $("#form-register").validate({
                    errorClass: "help-block animation-slideDown",
                    errorElement: "div",
                    errorPlacement: function (e, r) {
                        r.parents(".form-group > div").append(e)
                    },
                    highlight: function (e) {
                        $(e).closest(".form-group").removeClass("has-success has-error").addClass("has-error"),
                            $(e).closest(".help-block").remove()
                    },
                    success: function (e) {
                        2 === e.closest(".form-group").find(".help-block").length ? e.closest(".help-block").remove() : (e.closest(".form-group").removeClass("has-success has-error"),
                            e.closest(".help-block").remove())
                    },
                    rules: {
                        "register-firstname": {
                            required: !0,
                            minlength: 2
                        },
                        "register-lastname": {
                            required: !0,
                            minlength: 2
                        },
                        "register-email": {
                            required: !0,
                            email: !0
                        },
                        "register-password": {
                            required: !0,
                            minlength: 5
                        },
                        "register-password-verify": {
                            required: !0,
                            equalTo: "#register-password"
                        },
                        "register-terms": {
                            required: !0
                        }
                    },
                    messages: {
                        "register-firstname": {
                            required: "Please enter your firstname",
                            minlength: "Please enter your firstname"
                        },
                        "register-lastname": {
                            required: "Please enter your lastname",
                            minlength: "Please enter your lastname"
                        },
                        "register-email": "Please enter a valid email address",
                        "register-password": {
                            required: "Please provide a password",
                            minlength: "Your password must be at least 5 characters long"
                        },
                        "register-password-verify": {
                            required: "Please provide a password",
                            minlength: "Your password must be at least 5 characters long",
                            equalTo: "Please enter the same password as above"
                        },
                        "register-terms": {
                            required: "Please accept the terms!"
                        }
                    }
                })
        }
    }
}();