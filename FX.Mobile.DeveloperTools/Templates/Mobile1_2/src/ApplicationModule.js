Ext.namespace("Mobile.[MODULE:Custom]");

Mobile.[MODULE:Custom].ApplicationModule = Ext.extend(Sage.Platform.Mobile.ApplicationModule, {
    loadCustomizations: function() {
        Mobile.[MODULE:Custom].ApplicationModule.superclass.loadCustomizations.apply(this, arguments);
		
		this.registerCustomizations();
	},
    registerCustomizations: function() {
	
		// ADD CUSTOMIZATIONS HERE
		
		// Sample customization to change Type label
		this.registerCustomization('detail', 'account_detail', {
			at: function(row) { return row.name == 'Type'; },
			type: 'modify',
			value: {
				label: 'type x'
			}
		});
		
		
	}
});
