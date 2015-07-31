require.config({
    baseUrl: '/Scripts', // root from which the modules will be looked for
    urlArgs: 'bust=v1.0.0',
    paths: {
        // load third party libraries that aren’t defined as Require modules
        jquery: 'jquery-1.11.3',
        jQueryValidate: 'jquery.validate.min',
        underscore: 'underscore.min'
    },
    waitSeconds: 30, // the number of seconds to wait before giving up on loading a script
    shim: {
        jquery: { exports: '$' },  // attaches "$" to the window object
        underscore: { exports: '_' }
    }
});