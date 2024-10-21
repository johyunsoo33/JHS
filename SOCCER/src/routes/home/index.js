const express = require("express");
const router = express.Router();

const home = require("./home.ctrl")

router.get("/", home.output.main);
router.get("/login", home.output.login);
router.get("/creatId", home.output.creatId);

module.exports = router;