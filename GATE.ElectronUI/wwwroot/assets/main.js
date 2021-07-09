
(function ($) {

    $.fn.assignNavigation = function (moduleName) {
        var selectedNavigation = '',
            testRunLibraryNavigation = `<h5 class="nav-category">
                                            <svg class="nav-icon" > <use xlink: href="assets/img/icons.svg#icon-menu"></use></svg >
                                                Regression
                                                </h5 >
                                        <button type="button" id="button-codepreview" data-section="codepreview" class="nav-button">COSTPOINT_MM_REG</button>
                                        <button type="button" id="button-shortcuts" data-section="shortcuts" class="nav-button">COSTPOINT_AC_REG</button>`,
            settingsEnvironmentNavigation = ''; // Alexis: to assign HTML for settings navigation here

        $(this).empty();

        switch (moduleName) {
            case 'testRunLibrary':
                selectedNavigation = testRunLibraryNavigation;
                break;
            case 'settingsEnvironment':
                selectedNavigation = settingsEnvironmentNavigation;
                break;
            default:
                selectedNavigation = testRunLibraryNavigation;
                break;
        }

        $(this).append(selectedNavigation);
    };

    // Defaults as TestRunsLibrary
    $('.gate-navigation').assignNavigation();

    /*
     On click event that will handle the following:
        1. Assign navigation specified for settings environment
        2. Override default item on nav bar based on settings landing page
        3. Dynamic fontawesome icon - if settings page is loaded then fa-cog should be changed to an icon that will indicate settings is open
     */
    $("a#gate-settings").click(function () {
        console.log('settings has been triggered');
        $('.gate-navigation').assignNavigation('settingsEnvironment');

    });

}(jQuery));