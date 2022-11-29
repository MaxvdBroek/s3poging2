import Navbar from './Navbar.vue'

describe('<Navbar />', () => {
  it('renders', () => {
    // see: https://test-utils.vuejs.org/guide/
    cy.mount(Navbar)
  })
})