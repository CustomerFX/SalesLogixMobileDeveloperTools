define('configuration/[MODULE-LC:Custom]/development', ['configuration/development', 'Mobile/[MODULE:Custom]/ApplicationModule'], function(baseConfiguration, [MODULE:Custom]ApplicationModule) {
    return mergeConfiguration(baseConfiguration, {
        modules: [
            new [MODULE:Custom]ApplicationModule()
        ]
    });
});