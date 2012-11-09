define('configuration/[MODULE-LC:Custom]/production', ['configuration/production', 'Mobile/[MODULE:Custom]/ApplicationModule'], function(baseConfiguration, [MODULE:Custom]ApplicationModule) {
    return mergeConfiguration(baseConfiguration, {
        modules: [
            new [MODULE:Custom]ApplicationModule()
        ]
    });
});