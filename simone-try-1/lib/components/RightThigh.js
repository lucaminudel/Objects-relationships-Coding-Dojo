let Status = require('../mixins/Status')
let MaxCharge = require('../mixins/MaxCharge')

class RightThigh extends Status(MaxCharge()) {
  constructor () {
    super(...arguments)
  }

  printStatus (print) {
    print(this.status)
  }
}

module.exports = RightThigh
