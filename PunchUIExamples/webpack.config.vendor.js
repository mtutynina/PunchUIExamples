const path = require('path');
const webpack = require('webpack');

module.exports = (env) => {
    return [{
        stats: { modules: false },
        entry: {
            vendor: ["knockout"],
        },
        output: {
            path: path.join(__dirname, 'wwwroot', 'dist'),
            publicPath: 'dist/',
            filename: '[name].js',
            library: '[name]_[hash]',
        },
        externals: [
            {
                "window": "window",
                "document": "document",
                "navigator": "navigator",
                "JSON": "JSON"
            }
        ],
        module: {
            rules: [
            ]
        },
        plugins: [
        ]
    }];
};
