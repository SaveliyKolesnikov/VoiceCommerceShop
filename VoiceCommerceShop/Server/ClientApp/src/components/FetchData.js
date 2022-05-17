import React, { Component } from 'react';
import { AudioRecorder } from './AudioRecorder.jsx'

export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor(props) {
    super(props);
    this.state = { cars: [], loading: true, searchQuery: "" };
  }

  componentDidMount() {
    this.populateWeatherData();
  }

  onRecordingFinished = async (blob) => {
    const searchRequestText = await this.sendAudioRequest(blob);
    this.setState({ searchQuery: searchRequestText }, () => {
      this.queryFilteredCars(searchRequestText);
    });
  }

  queryFilteredCars = async (searchRequestText) => {
    this.setState({ loading: true });
    const filteredCarsResponse = await fetch(`/cars/filter-by-text?inputText=${searchRequestText}`);
    const filteredCars = await filteredCarsResponse.json();
    this.setState({ cars: filteredCars, loading: false });
  }

  sendAudioRequest = async (blob) => {
    const formData = new FormData();
    formData.append("audio", blob, "test.wav");
    const res = await fetch('/cars/voice-search', {
      method: "POST",
      body: formData
    });
    return await res.text();
  }

  renderForecastsTable = (cars) => {
    return (
      <>
        <span>Search query: {this.state.searchQuery || "---"}</span>
        <AudioRecorder onRecordingFinished={this.onRecordingFinished}></AudioRecorder>
        <table className='table table-striped' aria-labelledby="tabelLabel">
          <thead>
            <tr>
              <th>Brand</th>
              <th>Model</th>
              <th>Color</th>
              <th>Price</th>
            </tr>
          </thead>
          <tbody>
            {cars?.map(car =>
              <tr key={car.carKey}>
                <td>{car.brand}</td>
                <td>{car.model}</td>
                <td>{car.color}</td>
                <td>{car.price}</td>
              </tr>
            )}
          </tbody>
        </table>
      </>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : this.renderForecastsTable(this.state.cars);

    return (
      <div>
        <h1 id="tabelLabel" >Weather forecast</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async populateWeatherData() {
    const response = await fetch('cars');
    const data = await response.json();
    this.setState({ cars: data, loading: false });
  }
}
