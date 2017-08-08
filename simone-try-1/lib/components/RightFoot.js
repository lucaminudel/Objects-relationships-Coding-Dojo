let Status = require('../mixins/Status')
let MaxCharge = require('../mixins/MaxCharge')

class RightFoot extends Status(MaxCharge()) {
  constructor (args) {
    super(args)
  }

  printStatus (print) {
    print(this.status)
  }
}

module.exports = RightFoot
