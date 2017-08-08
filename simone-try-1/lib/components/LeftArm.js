let Status = require('../mixins/Status')
let MaxCharge = require('../mixins/MaxCharge')

class LeftArm extends Status(MaxCharge()) {
  constructor () {
    super(...arguments)
  }

  printStatus (print) {
    print(this.status)
  }
}

module.exports = LeftArm
