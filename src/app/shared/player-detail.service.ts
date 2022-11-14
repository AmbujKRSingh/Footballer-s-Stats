import { Injectable } from '@angular/core';
import { PlayerDetail } from './player-detail.model';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class PlayerDetailService {

  constructor(private http: HttpClient) { }

  readonly baseURL = 'https://localhost:7213/api/PlayerDetail'
  formData: PlayerDetail = new PlayerDetail();
  list: PlayerDetail[];

  postPlayerDetail() {
    return this.http.post(this.baseURL, this.formData);
  }

  putPlayerDetail() {
    return this.http.put(`${this.baseURL}/${this.formData.playerDetailId}`, this.formData);
  }

  deletePlayerDetail(id: number) {
    return this.http.delete(`${this.baseURL}/${id}`);
  }

  refreshList() {
    this.http.get(this.baseURL)
      .toPromise()
      .then(res =>this.list = res as PlayerDetail[]);
  }


}
