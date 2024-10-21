const output = {
    main : (req,res) =>{
        res.render("home/index");
    },
    login : (req,res) =>{
        res.render("login/login");
    },
    creatId : (req,res) =>{
        res.render("login/creatId");
    }
}

module.exports = {
    output,
}