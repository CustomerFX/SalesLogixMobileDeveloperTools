define('Mobile/[MODULE:Custom]/ApplicationModule', [
    'Sage/Platform/Mobile/ApplicationModule'
], function () {
    return dojo.declare('Mobile.[MODULE:Custom].ApplicationModule', Sage.Platform.Mobile.ApplicationModule, {
        loadCustomizations: function () {
            this.inherited(arguments);

            // ADD CUSTOMIZATIONS HERE

            // Sample customization to change Type label
            this.registerCustomization('detail', 'account_detail', {
                at: function (row) { return row.name == 'Type'; },
                type: 'modify',
                value: {
                    label: 'type x'
                }
            });


        }
    });
});