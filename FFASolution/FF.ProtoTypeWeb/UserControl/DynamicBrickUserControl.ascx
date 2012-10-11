﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DynamicBrickUserControl.ascx.cs" Inherits="FF.ProtoTypeWeb.UserControl.DynamicBrickUserControl" %>
<div class="metro" id="start-page">
    <div class="layout">
        <!-- Header -->
        <div class="header" id="header">
            <div class="user-login">
                <div class="name">
                    <span class="first-name">Sergey</span>
                    <span class="last-name">Pimenov</span>
                </div>
                <div class="avatar">
                    <img src="img/myface.jpg"/>
                </div>
            </div>
            <h1>Start</h1>
        </div>

        <div class="metro-scroll">
            <div class="content">
                <div class="metro-sections">
                    <div class="metro-section size6">
                        <div class="tile tile-double bg-color-blueLight">
                            <div class="tile-icon">
                                <img src="img/mail-128.png"/>
                            </div>
                            <div class="tile-counter">10</div>
                            <div class="tile-text">
                                <h2>mattberg@live.com</h2>
                                <p>RE: Wedding Announcement!</p>
                                <p>Congratulations! I'm realy looking forward to celebrating with you all. Thanks for the ...</p>
                            </div>
                        </div>

                        <div class="tile tile-double">
                            <div class="tile-image">
                                <img src="img/5.jpg"/>
                            </div>

                            <div class="tile-overlay bg-color-orangeDark">
                                <div class="tile-overlay-icon"><img src="img/messages-48.png"/></div>
                                <div class="tile-overlay-text">Wendy Richardson commented on you photo</div>
                                <div class="tile-overlay-counter">7</div>
                            </div>
                        </div>

                        <div class="tile tile-double bg-color-orange">
                            <div class="tile-calendar-event">
                                <div class="event-date">
                                    <div class="event-date-num">01</div>
                                    <div class="event-date-month">JUNE</div>
                                </div>
                                <div class="event-data">
                                    <div class="title">All Things Digital</div>
                                    <div class="text">
                                        Rancho Palos Verdes, CA
                                        <br />8:00 AM - 5:00 PM
                                    </div>
                                </div>
                            </div>
                            <div class="tile-label">Calendar</div>
                        </div>

                        <div class="tile bg-color-blue">
                            <div class="tile-icon-large">
                                <img src="img/internet-explorer-128.png"/>
                            </div>
                            <div class="tile-label">Internet Explorer</div>
                        </div>

                        <div class="tile">
                            <div class="tile-image">
                                <img src="img/myface.jpg"/>
                            </div>
                        </div>

                        <div class="tile tile-double bg-color-greenLight">
                            <div class="tile-text-data">
                                <div class="title">My Investments &#9650;2.3%</div>
                                <div class="text">
                                    <table width="100%">
                                        <tr>
                                            <td>&#9650;</td>
                                            <td width="50">3.6%</td>
                                            <td>Roth IRA (TD Ameritrade)</td>
                                        </tr>
                                        <tr>
                                            <td>&#9650;</td>
                                            <td>2.7%</td>
                                            <td>401K Fund (Fidelity)</td>
                                        </tr>
                                        <tr>
                                            <td>&#9660;</td>
                                            <td>1.4%</td>
                                            <td>Investment Portfolio</td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                            <div class="tile-icon"><img src="img/stock-up-48.png"/></div>
                        </div>

                        <div class="tile tile-double">
                            <div class="tile-image-slider" data-speed="500" data-direction="scrollLeft">
                                <img src="img/1.jpg"/>
                                <img src="img/2.jpg"/>
                                <img src="img/3.jpg"/>
                                <img src="img/4.jpg"/>
                                <img src="img/5.jpg"/>
                            </div>
                            <div id="next"></div>
                            <div class="tile-label">Pictures</div>
                        </div>

                        <div class="tile tile-double bg-color-pinkDark">
                            <div class="tile-icon-title">
                                <img src="img/market-128.png"/>
                                <h2>Store</h2>
                            </div>
                        </div>

                        <div class="tile tile-double bg-color-blueDark">
                            <div class="tile-image-message">
                                <div class="image"><img src="img/michael.jpg"/></div>
                                <div class="message">
                                    <div class="title">michael_angiulo</div>
                                    <div class="text">
                                        I just saw Thor last night. It was awesome! I think you'd love it. RT @julie_green
                                    </div>
                                </div>
                            </div>
                            <div class="tile-label">Tweet@rama</div>
                        </div>

                        <div class="tile tile-double bg-color-blueLight">
                            <div class="tile-image-message">
                                <div class="image"><img src="img/sun-128.png"/></div>
                                <div class="message">
                                    <div class="title">71&deg; Sunny</div>
                                    <div class="text">
                                        Wednesday: 65&deg; Cloudy
                                        <br />Thursday: 67&deg; Sunny
                                        <br />Friday: 68&deg; Rain
                                    </div>
                                </div>
                            </div>
                            <div class="tile-label">Weather</div>
                        </div>
                    </div>

                    <div class="metro-section size2">
                        <div class="tile tile-double bg-color-purple">
                            <div class="tile-icon-large">
                                <img src="img/head-phone-128.png"/>
                            </div>
                            <div class="tile-label">Music</div>
                        </div>

                        <div class="tile bg-color-pinkDark">
                            <div class="tile-icon-large">
                                <img src="img/film-128.png"/>
                            </div>
                            <div class="tile-label">Video</div>
                        </div>

                        <div class="tile bg-color-greenLight">
                            <div class="tile-icon-large">
                                <img src="img/games-128.png"/>
                            </div>
                            <div class="tile-label">Games</div>
                        </div>

                        <div class="tile tile-double">
                            <div class="tile-image">
                                <img src="img/windows-8-fish.jpg" />
                            </div>
                            <div class="tile-label">Desktop</div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script type="text/javascript">
    $(function () {
        $("body").metroUI();
    })

    $(function () {
        var new_width = 0;

        $(".metro-section").each(function () {
            var w = $(this).width() + 80;
            new_width += w;
        });

        $(".metro-sections").css("width", new_width);

        $(".metro-scroll").height($(window).height() - 10);
        //$(".metro-scroll").width($(".metro-sections").width());

    })
    </script>