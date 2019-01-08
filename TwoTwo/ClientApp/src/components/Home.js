import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <h1>Hello, world! </h1>
        <h1>From Boot strap 4! (finally)</h1>
      
        <a className="btn btn-warning" href="/health"> Check my Health!</a>
      </div>
    );
  }
}
