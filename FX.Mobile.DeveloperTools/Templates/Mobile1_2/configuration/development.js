Ext.namespace("Configuration.development");

(function() {
	var merge = function(configuration, moduleConfiguration) {
		if (configuration)
		{
			if (configuration.modules && moduleConfiguration.modules)
				configuration.modules = configuration.modules.concat(moduleConfiguration.modules);

			if (configuration.connections && moduleConfiguration.connections)
				configuration.connections = Ext.apply(configuration.connections, moduleConfiguration.connections);
		}
	};

	merge(Configuration.development, {
		modules: [
			new Mobile.[MODULE:Custom].ApplicationModule()
		]
	});
})();