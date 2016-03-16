var path = require("path");

module.exports = {
    entry: "./src/app.module",
    output: {
        path: path.resolve("./build/"),
        filename: "bundle.js"
    },
    devtool: 'source-map',
    resolve: {
        extensions: ['', '.webpack.js', '.web.js', '.ts', '.js']
    },
    plugins: [
        //new webpack.optimize.UglifyJsPlugin()
    ],
    resolveLoader: {
        modulesDirectories: [
            './node_modules'
        ]
    },
    module: {
        loaders: [
            { test: /\.ts$/, loader: 'ts' }
        ]
    }
};