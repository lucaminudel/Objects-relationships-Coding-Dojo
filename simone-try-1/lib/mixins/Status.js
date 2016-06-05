module.exports = (Base = Object) => class Status extends Base {
  constructor () {
    super(...arguments)
    this._status = 'off'
  }

  get status () {
    return this._status
  }

  switchOn () {
    this._status = 'on'
  }

  switchOff () {
    this._status = 'off'
  }
}
