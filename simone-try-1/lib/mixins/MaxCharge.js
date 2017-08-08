let mandatory = require('../mandatory')

module.exports = (Base = Object) => class MaxCharge extends Base {
  constructor ({maxCharge = mandatory('maxCharge')} = {}) {
    super(...arguments)
    this._maxCharge = maxCharge
  }

  get maxCharge () {
    return this._maxCharge
  }

  get chargeCost () {
    return this.maxCharge * 0.2
  }
}
