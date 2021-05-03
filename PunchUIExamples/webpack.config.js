const path = require('path');
const fs = require('fs')
const CheckerPlugin = require('awesome-typescript-loader').CheckerPlugin;
const bundleOutputDir = './wwwroot/dist';
// absolute paths to all symlinked modules inside `nodeModulesPath`
// adapted from https://github.com/webpack/webpack/issues/811#issuecomment-405199263
const findLinkedModules = (nodeModulesPath) => {
    const modules = []

    fs.readdirSync(nodeModulesPath).forEach(dirname => {
        const modulePath = path.resolve(nodeModulesPath, dirname)
        const stat = fs.lstatSync(modulePath)

        if (dirname.startsWith('.')) {
            // not a module or scope, ignore
        } else if (dirname.startsWith('@')) {
            // scoped modules
            modules.push(...findLinkedModules(modulePath))
        } else if (stat.isSymbolicLink()) {
            const realPath = fs.realpathSync(modulePath)
            const realModulePath = path.resolve(realPath, 'node_modules')

            modules.push(realModulePath)
        }
    })

    return modules
}
module.exports = (env) => {
    return [{
        stats: { modules: false },
        entry: {
            'pagination-example': './app/pagination',
        },
        resolve: {
            extensions: ['.ts', '.js'],
            symlinks: false,
            modules: [
                // provide absolute path to the main node_modules,
                // to avoid webpack searching around and getting confused
                // see https://webpack.js.org/configuration/resolve/#resolve-modules
                path.resolve('node_modules'),
                // include linked node_modules as fallback, in case the deps haven't
                // yet propagated to the main node_modules
                ...findLinkedModules(path.resolve('node_modules')),
                ]
        },
        output: {
            path: path.join(__dirname, bundleOutputDir),
            filename: '[name].js',
            publicPath: "dist/",
            library: '[name]',
            libraryTarget: 'window',
            libraryExport: 'default'
        },
        module: {
            rules: [
                { test: /\.ts?$/, use: 'awesome-typescript-loader?silent=true' },
            ]
        },
        plugins: [
            new CheckerPlugin(),
        ],
    }];
};
