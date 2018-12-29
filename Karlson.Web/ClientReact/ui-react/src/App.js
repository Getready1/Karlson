import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';

class App extends Component {
  render() {
    return (
<div className="register-page">
  
  <nav className="navbar navbar-expand-lg fixed-top navbar-transparent " color-on-scroll="100">
    <div className="container">
      <div className="navbar-translate">
        <a className="navbar-brand" href="https://demos.creative-tim.com/blk-design-system/index.html" rel="tooltip" title="Designed and Coded by Creative Tim" data-placement="bottom" target="_blank">
          <span>BLK•</span> Design System
        </a>
        <button className="navbar-toggler navbar-toggler" type="button" data-toggle="collapse" data-target="#navigation" aria-controls="navigation-index" aria-expanded="false" aria-label="Toggle navigation">
          <span className="navbar-toggler-bar bar1"></span>
          <span className="navbar-toggler-bar bar2"></span>
          <span className="navbar-toggler-bar bar3"></span>
        </button>
      </div>
      <div className="collapse navbar-collapse justify-content-end" id="navigation">
        <div className="navbar-collapse-header">
          <div className="row">
            <div className="col-6 collapse-brand">
              <a>
                BLK•
              </a>
            </div>
            <div className="col-6 collapse-close text-right">
              <button type="button" className="navbar-toggler" data-toggle="collapse" data-target="#navigation" aria-controls="navigation-index" aria-expanded="false" aria-label="Toggle navigation">
                <i className="tim-icons icon-simple-remove"></i>
              </button>
            </div>
          </div>
        </div>
        <ul className="navbar-nav">
          <li className="nav-item p-0">
            <a className="nav-link" rel="tooltip" title="Follow us on Twitter" data-placement="bottom" href="https://twitter.com/CreativeTim" target="_blank">
              <i className="fab fa-twitter"></i>
              <p className="d-lg-none d-xl-none">Twitter</p>
            </a>
          </li>
          <li className="nav-item p-0">
            <a className="nav-link" rel="tooltip" title="Like us on Facebook" data-placement="bottom" href="https://www.facebook.com/CreativeTim" target="_blank">
              <i className="fab fa-facebook-square"></i>
              <p className="d-lg-none d-xl-none">Facebook</p>
            </a>
          </li>
          <li className="nav-item p-0">
            <a className="nav-link" rel="tooltip" title="Follow us on Instagram" data-placement="bottom" href="https://www.instagram.com/CreativeTimOfficial" target="_blank">
              <i className="fab fa-instagram"></i>
              <p className="d-lg-none d-xl-none">Instagram</p>
            </a>
          </li>
          <li className="nav-item">
            <a className="nav-link" href="../index.html">Back to Kit</a>
          </li>
          <li className="nav-item">
            <a className="nav-link" href="https://github.com/creativetimofficial/blk-design-system/issues">Have an issue?</a>
          </li>
        </ul>
      </div>
    </div>
  </nav>

  <div className="wrapper">
    <div className="page-header">
      <div className="page-header-image"></div>
      <div className="content">
        <div className="container">
          <div className="row">
            <div className="col-lg-5 col-md-6 offset-lg-0 offset-md-3">
              <div id="square7" className="square square-7"></div>
              <div id="square8" className="square square-8"></div>
              <div className="card card-register">
                <div className="card-header">
                  <img className="card-img" src="../assets/img/square1.png" alt="Card image"/>
                  <h4 className="card-title">Register</h4>
                </div>
                <div className="card-body">
                  <form className="form">
                    <div className="input-group">
                      <div className="input-group-prepend">
                        <div className="input-group-text">
                          <i className="tim-icons icon-single-02"></i>
                        </div>
                      </div>
                      <input type="text" className="form-control" placeholder="Full Name"/>
                    </div>
                    <div className="input-group">
                      <div className="input-group-prepend">
                        <div className="input-group-text">
                          <i className="tim-icons icon-email-85"></i>
                        </div>
                      </div>
                      <input type="text" placeholder="Email" className="form-control"/>
                    </div>
                    <div className="input-group">
                      <div className="input-group-prepend">
                        <div className="input-group-text">
                          <i className="tim-icons icon-lock-circle"></i>
                        </div>
                      </div>
                      <input type="text" className="form-control" placeholder="Password"/>
                    </div>
                    <div className="form-check text-left">
                    </div>
                  </form>
                </div>
                <div className="card-footer">
                  <a href="javascript:void(0)" className="btn btn-info btn-round btn-lg">Get Started</a>
                </div>
              </div>
            </div>
          </div>
          <div className="register-bg"></div>
          <div id="square1" className="square square-1"></div>
          <div id="square2" className="square square-2"></div>
          <div id="square3" className="square square-3"></div>
          <div id="square4" className="square square-4"></div>
          <div id="square5" className="square square-5"></div>
          <div id="square6" className="square square-6"></div>
        </div>
      </div>
    </div>
    <footer className="footer">
      <div className="container">
        <div className="row">
          <div className="col-md-3">
            <h1 className="title">BLK•</h1>
          </div>
          <div className="col-md-3">
            <ul className="nav">
              <li className="nav-item">
                <a href="../index.html" className="nav-link">
                  Home
                </a>
              </li>
              <li className="nav-item">
                <a href="../examples/landing-page.html" className="nav-link">
                  Landing
                </a>
              </li>
              <li className="nav-item">
                <a href="../examples/register-page.html" className="nav-link">
                  Register
                </a>
              </li>
              <li className="nav-item">
                <a href="../examples/profile-page.html" className="nav-link">
                  Profile
                </a>
              </li>
            </ul>
          </div>
          <div className="col-md-3">
            <ul className="nav">
              <li className="nav-item">
                <a href="https://creative-tim.com/contact-us" className="nav-link">
                  Contact Us
                </a>
              </li>
              <li className="nav-item">
                <a href="https://creative-tim.com/about-us" className="nav-link">
                  About Us
                </a>
              </li>
              <li className="nav-item">
                <a href="https://creative-tim.com/blog" className="nav-link">
                  Blog
                </a>
              </li>
              <li className="nav-item">
                <a href="https://opensource.org/licenses/MIT" className="nav-link">
                  License
                </a>
              </li>
            </ul>
          </div>
          <div className="col-md-3">
            <h3 className="title">Follow us:</h3>
            <div className="btn-wrapper profile">
              <a target="_blank" href="https://twitter.com/creativetim" className="btn btn-icon btn-neutral btn-round btn-simple" data-toggle="tooltip" data-original-title="Follow us">
                <i className="fab fa-twitter"></i>
              </a>
              <a target="_blank" href="https://www.facebook.com/creativetim" className="btn btn-icon btn-neutral btn-round btn-simple" data-toggle="tooltip" data-original-title="Like us">
                <i className="fab fa-facebook-square"></i>
              </a>
              <a target="_blank" href="https://dribbble.com/creativetim" className="btn btn-icon btn-neutral  btn-round btn-simple" data-toggle="tooltip" data-original-title="Follow us">
                <i className="fab fa-dribbble"></i>
              </a>
            </div>
          </div>
        </div>
      </div>
    </footer>
  </div>

</div>
    );
  }
}

export default App;
