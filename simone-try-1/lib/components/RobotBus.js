let Status = require('../mixins/Status')
let mandatory = require('../mandatory')

class RobotBus extends Status() {
  constructor ({
      leftArm = mandatory('leftArm'),
      rightFoot = mandatory('rightFoot'),
      rightThigh = mandatory('rightThigh')
  } = {}) {
    super(...arguments)
    this._leftArm = leftArm
    this._rightFoot = rightFoot
    this._rightThigh = rightThigh
  }

  printStatus (print, indent = 0) {
    print(indent, 'Robot:', this.status)
    this._leftArm.printStatus(print.bind(null, indent + 2, 'Left Arm:'), indent + 2)
    this._rightFoot.printStatus(print.bind(null, indent + 2, 'Right foot:'), indent + 2)
    this._rightThigh.printStatus(print.bind(null, indent + 2, 'Right thigh:'), indent + 2)
  }

  get rechargeCost () {
    return this._leftArm.chargeCost
        + this._rightFoot.chargeCost
        + this._rightThigh.chargeCost
  }
}

module.exports = RobotBus
