'use strict';

var url = require('url');


var Default = require('./DefaultService');


module.exports.getGET = function getGET (req, res, next) {
  Default.getGET(req.swagger.params, res, next);
};
